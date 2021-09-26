using ModuleHomework.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleHomework.Models.Car.CityCars
{
 public abstract class CityCar : Car
  {
    public FuelType fuelType { get; init; }
  }
}
