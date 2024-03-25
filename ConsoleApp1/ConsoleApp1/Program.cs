using ConsoleApp1.Containers;
using ConsoleApp1.Exceptions;

// LiquidContainer liquidContainer = new LiquidContainer(0, 10, 5, 3, "KON-LC-1", 1000, true);
//
// try {
//     liquidContainer.LoadCargo(800);
//     Console.WriteLine("Cargo loaded successfully.");
// }
// catch (OverFillException ex) {
//     Console.WriteLine($"Error: {ex.Message}");
// }
//
// Console.ReadLine();

// try
// {
//     RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer(0, 10, 5, 3, "KON-RC-1", 100, "Fruits", 5);
//     
//     refrigeratedContainer.LoadCargo(500, 5); // Przykładowy ładunek o masie 50 i wymaganej temperaturze 5 stopni
//
//     Console.WriteLine("Cargo loaded successfully.");
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine($"Error: {ex.Message}");
// }
// catch (OverFillException ex)
// {
//     Console.WriteLine($"Error: {ex.Message}");
// }
//
// Console.ReadLine();
List<Container> containerList = new List<Container>();
while (true)
{
    Console.WriteLine("1 - Create container");
    Console.WriteLine("2 - Create ship");
    Console.WriteLine("3 - Exit");

    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("What type of container do you want to create?");
            Console.WriteLine("1 - LiquidContainer");
            Console.WriteLine("2 - GasContainer");
            Console.WriteLine("3 - Refigerated Cintainer");

            string containerChoice = Console.ReadLine();

            switch (containerChoice)
            {
                case "1":
                    try {
                        LiquidContainer liquidContainer = new LiquidContainer(0, 10, 5, 3, "KON-LC-1", 100, true);
                        liquidContainer.LoadCargo(50);
                        containerList.Add(liquidContainer);

                        Console.WriteLine("LiquidContainer created and cargo loaded successfully.");
                    }
                    catch (ArgumentException ex) {
                        Console.WriteLine(ex.Message);
                    }
                    catch (OverFillException ex) {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case "2":
                    try {
                        GasContainer gasContainer = new GasContainer(0, 10, 5, 3, "KON-GC-1", 100, 1.5);
                        gasContainer.LoadCargo(50);
                        containerList.Add(gasContainer);

                        Console.WriteLine("GasContainer created and cargo loaded successfully.");
                    }
                    catch (ArgumentException ex) {
                        Console.WriteLine(ex.Message);
                    }
                    catch (OverFillException ex) {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case "3":
                    try {
                        RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer(0, 10, 5, 3, "KON-RC-1", 100, "Fruits", 5);
                        refrigeratedContainer.LoadCargo(50, 5);
                        containerList.Add(refrigeratedContainer);

                        Console.WriteLine("RefrigeratedContainer created and cargo loaded successfully.");
                    }
                    catch (ArgumentException ex) {
                        Console.WriteLine(ex.Message);
                    }
                    catch (OverFillException ex) {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            break;

        case "2":
            Console.WriteLine("Ship created successfully.");
            break;

        case "3":
            Console.WriteLine("Exiting the program.");
            return;

        default:
            Console.WriteLine("Invalid input");
            break;
    }
}

