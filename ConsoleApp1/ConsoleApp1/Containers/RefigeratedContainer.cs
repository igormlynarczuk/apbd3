namespace ConsoleApp1.Containers;
using ConsoleApp1.Exceptions;

public class RefrigeratedContainer : Container
{
    public string ProductType { get; }
    public double ContainerTemperature { get; }

    public RefrigeratedContainer(double cargoWeight, double height, double selfWeight, double depth, string serialNumber, double maximumPayload, string productType, double containerTemperature) 
        : base(cargoWeight, height, selfWeight, depth, serialNumber, maximumPayload)
    {
        ProductType = productType;
        ContainerTemperature = containerTemperature;
    }
    
    public void LoadCargo(double cargoWeight, double cargoRequiredTemperature) {
        if (cargoRequiredTemperature < ContainerTemperature) {
            throw new ArgumentException("Container Temperature is to low");
        }
        base.LoadCargo(cargoWeight);
    }
}