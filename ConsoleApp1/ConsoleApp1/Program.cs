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
List<Ship> shipList = new List<Ship>();
while (true)
{
    Console.WriteLine("1 - Create container");
    Console.WriteLine("2 - Create ship");
    Console.WriteLine("3 - Load container onto ship");
    Console.WriteLine("4 - Print container information");
    Console.WriteLine("5 - Print ship information");
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
            shipList.Add(new Ship());
            break;

        case "3":
            Console.WriteLine("Which ship do you want to load the container onto?");
            Console.WriteLine("Available ships:");

            for (int i = 0; i < shipList.Count; i++) {
                Console.WriteLine(i);
            }

            int shipChoice = Console.Read();
            if (shipChoice > shipList.Count) {
                Console.WriteLine("Which container do you want to load onto the ship?");
                Console.WriteLine("Available containers:");

                for (int i = 0; i < containerList.Count; i++) {
                    Console.WriteLine(i + " - " + containerList[i].SerialNumber);
                }

                int containerChoiceForShip = Console.Read();
                if (containerChoiceForShip > containerList.Count)
                {
                    shipList[shipChoice].AddContainer(containerList[containerChoiceForShip]);
                    Console.WriteLine("Container loaded on the ship");
                }
            }
            break;
        
        case "4":
            Console.WriteLine("Available containers:");

            for (int i = 0; i < containerList.Count; i++) {
                Console.WriteLine(i + " - " + containerList[i].SerialNumber);
            }
            int index = Console.Read();
            if (index <= containerList.Count)
                break;
            
            Container container = containerList[index];
            if (container != null) {
                Console.WriteLine("Container Serial Number: " + container.SerialNumber);
                Console.WriteLine("Cargo Weight: " + container.CargoWeight);
                Console.WriteLine("Maximum Payload: " + container.MaximumPayload);
            }else {
                Console.WriteLine("Container not found");
            }
            break;
        
        case "5":
            Console.WriteLine("Enter ship ID:");
            int index2 = Console.Read();
            Ship ship = shipList[index2];
            if (ship != null)
            {
                Console.WriteLine($"Ship ID:" + index2);
                Console.WriteLine("Containers on the ship:");
                foreach (Container c in ship.containerList)
                {
                    Console.WriteLine("Serial Number: " + c.SerialNumber);
                }
            }
            else{
                Console.WriteLine("Ship not found");
            }
            break;

        default:
            Console.WriteLine("Invalid input");
            break;
    }
}

