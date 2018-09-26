using FleetSim.Objects.Enum;

namespace FleetSim.Objects
{
    public class Car : Vehicle
    {
        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, Color color)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.color = color;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        
    }
}
