using FleetSim.Objects.Enum;
using FleetSim.Objects.Interface;
using System;

namespace FleetSim.Objects
{
    public class Vehicle : IVehicle
    {
        private int _mileage;
        private Guid _VIN;
        private Color _color;
        private DateTime _LastServiceDate;
        private int _LastServiceMileage;

        public int mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }
        public Guid VIN
        {
            get { return _VIN; }
            set { _VIN = value; }
        }
        public Color color
        {
            get { return _color; }
            set { _color = value; }
        }
        public DateTime LastServiceDate
        {
            get { return _LastServiceDate; }
            set { _LastServiceDate = value; }
        }
        public int LastServiceMileage
        {
            get { return _LastServiceMileage; }
            set { _LastServiceMileage = value; }
        }
        public void AddToMileage(int mileage) => _mileage += mileage;

        public void TuneUp(string Make, string Model, int Year, FleetSim.Objects.Enum.Color color)
        {
            if (mileage - LastServiceMileage >= 30000)
            {
                LastServiceDate = DateTime.Now;
                LastServiceMileage = mileage;
                Console.WriteLine("Vehicle tuned up at " + " " + LastServiceMileage + " miles on " + LastServiceDate + " " + "for" + " " + Make + " " + Model + " " + Year + " " + color + " ");
            }
            if (mileage >= 100000)
            {
                RebuildEngine(Make, Model, Year, color);
            }
        }
        public void RebuildEngine(string Make, string Model, int Year, FleetSim.Objects.Enum.Color color)
        {
            mileage = 0;
            LastServiceMileage = 0;
            Console.WriteLine("Engine rebuilt on " + LastServiceDate + " " + "for" + " " + Model);
        }
    }
}