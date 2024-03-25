namespace ConsoleApp1.Containers;
using ConsoleApp1.Exceptions;

public abstract class Container
{
    public double CargoWeight { get; set; }
    public double Height { get; set; }
    public double SelfWeight { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; }
    public double MaximumPayload { get; set; }
    private static int lastSerialNumber = 0;

    public Container(double cargoWeight, double height, double selfWeight, double depth, string serialNumber, double maximumPayload)
    {
        CargoWeight = cargoWeight;
        Height = height;
        SelfWeight = selfWeight;
        Depth = depth;
        SerialNumber = serialNumber;
        MaximumPayload = maximumPayload;
    }
    public static string GenerateSerialNumber(string containerType, int serialNumber)
    {
        return "KON-"+containerType+"-"+(lastSerialNumber++);
    }
    public void UnloadCargo()
    {
        CargoWeight = 0;
    }
    public void LoadCargo(double cargoWeight)
    {
        if (cargoWeight > MaximumPayload) {
            throw new OverFillException($"Cargo weight {cargoWeight} exceeds maximum payload {MaximumPayload}.");
        }
        else {
            CargoWeight = cargoWeight;
        }
    }
}