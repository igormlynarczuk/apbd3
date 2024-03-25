using ConsoleApp1.Exceptions;
using ConsoleApp1.Containers;

public class GasContainer : Container, IHazardNotifier
{
    private double _pressure;

    public double Pressure;
    public GasContainer(double cargoWeight, double height, double selfWeight, double depth, string serialNumber, double maximumPayload, double pressure) 
        : base(cargoWeight, height, selfWeight, depth, serialNumber, maximumPayload)
    {
        Pressure = pressure;
    }
    public void NotifyDangerousSituation(string containerNumber)
    {
        Console.WriteLine($"Dangerous situation detected in gas container {containerNumber}");
    }
    public void UnloadCargo()
    {
        CargoWeight *= 0.05;
    }
}