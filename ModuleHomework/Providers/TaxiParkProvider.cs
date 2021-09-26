using ModuleHomework.Models.Car;
using ModuleHomework.Models.Car.CityCars.Coupes;
using ModuleHomework.Models.Car.CityCars.Hatchbacks;
using ModuleHomework.Models.Car.CityCars.Sedans;
using ModuleHomework.Models.Car.CityCars.Sedans.BusinessClassSedans;
using ModuleHomework.Models.Car.Minibuses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleHomework.Providers
{
  public class TaxiParkProvider : ITaxiParkProvider
  {
    public TaxiParkProvider()
    {
      TaxiPark = new Car[]
      {
        new Hatchback
        {
          Model = "Prius",
          manufacturer = Enums.Manufacturer.Toyota,
          transmissionType = Enums.TransmissionType.AutomaticTransmission,
          SeatsNumber = 5,
          fuelType = Enums.FuelType.Hybrid,
          IssueYear = 2011,
          Price = 10000,
          FuelPer100km = 4.4,
          hatchbackType = Enums.HatchbackType.Liftback,
        },

        new Sedan
        {
          Model = "Logan",
          manufacturer = Enums.Manufacturer.Renault,
          transmissionType = Enums.TransmissionType.ManualTransmission,
          SeatsNumber = 5,
          fuelType = Enums.FuelType.Gas,
          IssueYear = 2005,
          Price = 3200,
          FuelPer100km = 6.9,
          sedanType = Enums.SedanType.Hardtop,
        },

        new Minibus
        {
          Model = "Sprinter",
          manufacturer = Enums.Manufacturer.MercedesBenz,
          transmissionType = Enums.TransmissionType.ManualTransmission,
          SeatsNumber = 9,
          FuelPer100km = 8.6,
          IssueYear = 2006,
          Price = 16000,
          minibusType = Enums.MinibusType.PassengerType,
        },

        new Coupe
        {
          Model = "Beetle",
          manufacturer = Enums.Manufacturer.Volkswagen,
          transmissionType = Enums.TransmissionType.AutomatedManualTransmission,
          SeatsNumber = 4,
          FuelPer100km = 7.1,
          IssueYear = 2015,
          Price = 10500,
          fuelType = Enums.FuelType.Petrol,
          coupeType = Enums.CoupeType.TwoDoor,
        },

        new Sedan
        {
          Model = "Fusion",
          manufacturer = Enums.Manufacturer.Ford,
          SeatsNumber = 5,
          FuelPer100km = 6.1,
          fuelType = Enums.FuelType.Hybrid,
          IssueYear = 2016,
          Price = 12500,
          transmissionType = Enums.TransmissionType.AutomaticTransmission,
          sedanType = Enums.SedanType.FormalSedan,
        },

        new Hatchback
        {
          Model = "Leaf",
          manufacturer = Enums.Manufacturer.Nissan,
          SeatsNumber = 5,
          FuelPer100km = 0,
          fuelType = Enums.FuelType.Electric,
          IssueYear = 2011,
          Price = 9500,
          transmissionType = Enums.TransmissionType.AutomaticTransmission,
          hatchbackType = Enums.HatchbackType.Liftback,
        },

        new BusinessClassSedan
        {
          Model = "Camry",
          manufacturer = Enums.Manufacturer.Toyota,
          SeatsNumber = 5,
          fuelType = Enums.FuelType.Hybrid,
          FuelPer100km = 8.5,
          CarHatch = true,
          ClimateControl = true,
          HeatedSeats = true,
          IssueYear = 2019,
          Price = 31000,
          transmissionType = Enums.TransmissionType.AutomaticTransmission,
          sedanType = Enums.SedanType.FormalSedan,
        },

        new Sedan
        {
          Model = "3",
          manufacturer = Enums.Manufacturer.Mazda,
          SeatsNumber = 5,
          FuelPer100km = 6.7,
          fuelType = Enums.FuelType.Petrol,
          IssueYear = 2015,
          Price = 12500,
          sedanType = Enums.SedanType.Hardtop,
          transmissionType = Enums.TransmissionType.AutomaticTransmission,
        },

        new Coupe
        {
          Model = "Veloster",
          manufacturer = Enums.Manufacturer.Hyundai,
          SeatsNumber = 4,
          FuelPer100km = 6.1,
          coupeType = Enums.CoupeType.CombiCoupe,
          fuelType = Enums.FuelType.Petrol,
          transmissionType = Enums.TransmissionType.ManualTransmission,
          IssueYear = 2009,
          Price = 9500,
        },

        new BusinessClassSedan
        {
          Model = "S6",
          manufacturer = Enums.Manufacturer.Audi,
          SeatsNumber = 5,
          CarHatch = true,
          ClimateControl = true,
          FuelPer100km = 9.6,
          fuelType = Enums.FuelType.Diesel,
          HeatedSeats = true,
          IssueYear = 2021,
          Price = 46000,
          sedanType = Enums.SedanType.FormalSedan,
          transmissionType = Enums.TransmissionType.AutomaticTransmission,
        },

        new BusinessClassSedan
        {
          Model = "S500",
          manufacturer = Enums.Manufacturer.MercedesBenz,
          SeatsNumber = 9,
          CarHatch = true,
          ClimateControl = true,
          FuelPer100km = 13.1,
          fuelType = Enums.FuelType.Petrol,
          HeatedSeats = true,
          sedanType = Enums.SedanType.Limo,
          IssueYear = 2017,
          Price = 45000,
          transmissionType = Enums.TransmissionType.AutomaticTransmission,
        },
      };
    }

    public Car[] TaxiPark { get; }
  }

}