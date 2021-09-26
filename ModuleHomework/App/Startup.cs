using ModuleHomework.Common;
using ModuleHomework.Models.Car;
using ModuleHomework.Providers;
using ModuleHomework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleHomework.App
{
  public class Startup
  {
    private Car[] _taxiPark;
    private const int _taxiParkSize = 35;
    private readonly ISortService _sortService;
    private readonly ITaxiParkService _taxiParkService;
    private readonly ITaxiParkProvider _taxiParkProvider;

    public Startup()
    {
      _sortService = new SortService();
      _taxiParkService = new TaxiParkService(35);
      _taxiParkProvider = new TaxiParkProvider();

    }

    public void Run()
    {
      var rnd = new Random();
      for (var i = 0; i < _taxiParkSize; i++)
      {
        _taxiParkService.Add(_taxiParkProvider.TaxiPark[rnd.Next(_taxiParkProvider.TaxiPark.Length)]);
      }

      Console.WriteLine($"Taxi Park for today: ");
      _taxiPark = _taxiParkProvider.TaxiPark;
      foreach (var x in _taxiPark)
      {
        Console.WriteLine("{0} {1}", x.manufacturer, x.Model);
      }

      Console.WriteLine($"Total cost of today's taxi park: {_taxiParkService.TotalCost}$");

      _sortService.SortByFuelConsumption(_taxiPark, new FuelConsumptionComparer());

      Console.WriteLine($"Taxi park sorted by fuel consumption: ");
      foreach (var x in _taxiPark)
      {
        Console.WriteLine("{0} {1}", x.manufacturer, x.Model);
      }

      Console.WriteLine("Find cars produced in 2011: ");
      object searched = _taxiPark.TaxiSearch("IssueYear", "2011");

      Console.WriteLine("Find cars produced by Mazda: ");
      object searched1 = _taxiPark.TaxiSearch("manufacturer", "Mazda");



    }
  }
}
