public class InventoryRepository : IInventoryRepository
{
    private readonly List<InventoryItem> _items = new();
    private int _nextId = 1;

    public void AddItem(InventoryItem item)
    {
        item.Id = _nextId++;
        _items.Add(item);
    }

    public List<InventoryItem> GetItems()
    {
        return _items;
    }

    public InventoryItem GetItemById(int id)
    {
        return _items.FirstOrDefault(i => i.Id == id);
    }

    public void UpdateItem(InventoryItem item)
    {
        var existingItem = _items.FirstOrDefault(i => i.Id == item.Id);
        if (existingItem is null) return;
        existingItem.Name = item.Name;
        existingItem.Quantity = item.Quantity;
        existingItem.Price = item.Price;
    }

    public void DeleteItem(int id)
    {
        var item = _items.FirstOrDefault(i => i.Id == id);
        if (item is not null)
        {
            _items.Remove(item);
        }
    }
}