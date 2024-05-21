using BetterConsoleTables;

public class InventoryConsoleInterface
{
    private readonly InventoryUseCases _useCases;

    public InventoryConsoleInterface(InventoryUseCases useCases)
    {
        _useCases = useCases;
    }

    public void AddItem()
    {
        Console.Write("Enter item name: ");
        var name = Console.ReadLine();
        Console.Write("Enter item quantity: ");
        var quantity = int.Parse(Console.ReadLine());
        Console.Write("Enter item price: ");
        var price = decimal.Parse(Console.ReadLine());

        _useCases.AddItem(name, quantity, price);
        Console.WriteLine("Item added successfully.");
    }

    public void ListItems()
    {
        var items = _useCases.ListItems();
        if (!items.Any())
        {
            Console.WriteLine("No items found.");
            return;
        }

        var table = new Table(TableConfiguration.Unicode()).From(items.ToList());
        Console.WriteLine(table.ToString());
    }

    public void UpdateItem()
    {
        Console.Write("Enter item ID to update: ");
        var id = int.Parse(Console.ReadLine());
        Console.Write("Enter new name: ");
        var name = Console.ReadLine();
        Console.Write("Enter new quantity: ");
        var quantity = int.Parse(Console.ReadLine());
        Console.Write("Enter new price: ");
        var price = decimal.Parse(Console.ReadLine());

        _useCases.UpdateItem(id, name, quantity, price);
        Console.WriteLine("Item updated successfully.");
    }

    public void DeleteItem()
    {
        Console.Write("Enter item ID to delete: ");
        var id = int.Parse(Console.ReadLine());

        _useCases.DeleteItem(id);
        Console.WriteLine("Item deleted successfully.");
    }
}