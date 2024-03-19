namespace ConsoleApp1.Containers;

public abstract class Container
{
    public double CargoWeight { get; set;}
    public double Height { get; set;}

    public Container(double cargoWeight, double height)
    {
        CargoWeight = cargoWeight;
        Height = height;
    }
}