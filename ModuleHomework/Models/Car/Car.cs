using ModuleHomework.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleHomework.Models.Car
{
  public abstract class Car
  {

    public Manufacturer manufacturer { get; init; }

    public string Model { get; init; }

    public double Price { get; init; }

    public int IssueYear { get; init; }

    public int SeatsNumber { get; init; }

    public double FuelPer100km { get; init; }

    public TransmissionType transmissionType { get; init; }

  }
}
