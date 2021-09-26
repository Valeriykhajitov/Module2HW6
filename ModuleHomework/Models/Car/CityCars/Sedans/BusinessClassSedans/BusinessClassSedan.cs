using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleHomework.Models.Car.CityCars.Sedans.BusinessClassSedans
{
  public class BusinessClassSedan : Sedan
  {
    public bool HeatedSeats { get; init; }
    public bool ClimateControl { get; init; }

    public bool CarHatch { get; init; }
  }
}
