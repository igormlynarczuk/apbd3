using ConsoleApp1.Containers;

public class Ship
{
    public List<Container> containerList;

    public Ship(){
        containerList = new List<Container>();
    }

    public void AddContainer(Container container)
    {
        containerList.Add(container);
    }
}