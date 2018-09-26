using FleetSim.Objects;
using FleetSim.Objects.Enum;
using System;
using System.Collections.Generic;

namespace FleetSim.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var vehicle = new List<Vehicle>
                {
                    new Car("Ford", "Mustang", 1980, Color.Red),
                    new Car("Toyota", "Camry", 2017, Color.Blue),
                    new Car("Chevrolet", "Cruze", 2011, Color.Blue),
                    new Car("Honda", "Civic", 1984, Color.White),
                    new Car("Oldsmobile", "Cutlass", 1969, Color.Red)
                };
                int count = 0;
                {
                    foreach (Car car in vehicle)
                    {
                        for (count = 0; count <= 9; count++)
                        {
                            System.Threading.Thread.Sleep(50);
                            Random rnd = new Random();
                            int mileage = rnd.Next(5000, 15000);
                            car.mileage += mileage;
                            car.TuneUp(car.Make, car.Model, car.Year, car.color);
                        }
                    }
                }

                System.Console.ReadLine();
                System.Console.WriteLine();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("General Exception Thrown " + ex.Message);
            }
        }
    }
}
