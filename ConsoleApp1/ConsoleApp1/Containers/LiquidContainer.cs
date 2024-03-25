namespace ConsoleApp1.Containers;
using ConsoleApp1.Exceptions;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool _isHazardousCargo;
    public LiquidContainer(double cargoWeight, double height, double selfWeight, double depth, string serialNumber, double maximumPayload, bool isHazardousCargo) 
        : base(cargoWeight, height, selfWeight, depth, serialNumber, maximumPayload) 
    {
        _isHazardousCargo = isHazardousCargo;
    }
    public void LoadCargo(double cargoWeight)
    {
        if (_isHazardousCargo) {
            if (cargoWeight > MaximumPayload * 0.5)
            {
                NotifyDangerousSituation(SerialNumber);
                throw new OverFillException($"Attempted to load hazardous cargo exceeding 50% of container capacity.");
            }
        }
        else {
            if (cargoWeight > MaximumPayload * 0.9)
            {
                NotifyDangerousSituation(SerialNumber);
                throw new OverFillException($"Attempted to load non-hazardous cargo exceeding 90% of container capacity.");
            }
        }
        base.LoadCargo(cargoWeight);
    }
    public void NotifyDangerousSituation(string containerNumber)
    {
        Console.WriteLine($"Dangerous situation detected in container {containerNumber}. Notify relevant authorities.");
    }
}