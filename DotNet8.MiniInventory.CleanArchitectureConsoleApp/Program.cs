using DotNet8.MiniInventory.CleanArchitectureConsoleApp;

var repository = new InventoryRepository();
var useCases = new InventoryUseCases(repository);
var consoleInterface = new InventoryConsoleInterface(useCases);

while (true)
{
    Console.WriteLine("1. Add Item");
    Console.WriteLine("2. List Items");
    Console.WriteLine("3. Update Item");
    Console.WriteLine("4. Delete Item");
    Console.WriteLine("5. Exit");
    Console.Write("Select an option: ");

    var option = Console.ReadLine().ToInt();

    switch (option)
    {
        case 1:
            consoleInterface.AddItem();
            break;
        case 2:
            consoleInterface.ListItems();
            break;
        case 3:
            consoleInterface.UpdateItem();
            break;
        case 4:
            consoleInterface.DeleteItem();
            break;
        case 5:
            return;
        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }
}