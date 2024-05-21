var repository = new InventoryRepository();
var useCases = new InventoryService(repository);
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
            await consoleInterface.AddItem();
            break;
        case 2:
            await consoleInterface.ListItems();
            break;
        case 3:
            await consoleInterface.UpdateItem();
            break;
        case 4:
            await consoleInterface.DeleteItem();
            break;
        case 5:
            return;
        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }
}