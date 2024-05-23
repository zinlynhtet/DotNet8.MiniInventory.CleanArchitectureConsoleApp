public class InventoryConsoleInterface
{
    private readonly InventoryService _service;

    public InventoryConsoleInterface(InventoryService service) => _service = service;

    public async Task AddItem()
    {
        Console.Write("Enter item name: ");
        var name = Console.ReadLine();
        
        Console.Write("Enter item quantity: ");
        var quantity = Console.ReadLine().ToInt();
        
        Console.Write("Enter item price: ");
        var price = Console.ReadLine().ToDecimal();

        await _service.AddItemAsync(name, quantity, price);
        Console.WriteLine("Item added successfully.");
    }

    public async Task ListItems()
    {
        var items = await _service.ListItems();
        if (!items.Any())
        {
            Console.WriteLine("No items found.");
            return;
        }

        var table = new Table(TableConfiguration.Unicode()).From(items.ToList());
        Console.WriteLine(table.ToString());
    }

    public async Task UpdateItem()
    {
        Console.Write("Enter item ID to update: ");
        var id = Console.ReadLine().ToInt();
        
        Console.Write("Enter new name: ");
        var name = Console.ReadLine();
        
        Console.Write("Enter new quantity: ");
        var quantity = Console.ReadLine().ToInt();
        
        Console.Write("Enter new price: ");
        var price = Console.ReadLine().ToDecimal();

        await _service.UpdateItem(id, name, quantity, price);
        Console.WriteLine("Item updated successfully.");
    }

    public async Task DeleteItem()
    {
        Console.Write("Enter item ID to delete: ");
        var id = Console.ReadLine().ToInt();

        await _service.DeleteItem(id);
        Console.WriteLine("Item deleted successfully.");
    }
}