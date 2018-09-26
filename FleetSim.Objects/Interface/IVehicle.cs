namespace FleetSim.Objects.Interface
{
    interface IVehicle
    {
        void TuneUp(string Make, string Model, int Year, FleetSim.Objects.Enum.Color color);
        void RebuildEngine(string Make, string Model, int Year, FleetSim.Objects.Enum.Color color);
    }
}