public class InventoryRepository : IInventoryRepository
{
    private readonly List<InventoryItem> _items = new ();
    private int _nextId = 1;

    public Task AddItem(InventoryItem item)
    {
        item.Id = _nextId++;
        _items.Add(item);
        return Task.CompletedTask;
    }

    public Task<List<InventoryItem>> GetItems()
    {
        return Task.FromResult(_items);
    }

    public Task<InventoryItem> GetItemById(int id)
    {
        var item = _items.FirstOrDefault(i => i.Id == id);
        return Task.FromResult(item);
    }

    public Task UpdateItem(InventoryItem item)
    {
        var existingItem = _items.FirstOrDefault(i => i.Id == item.Id);
        if (existingItem != null)
        {
            existingItem.Name = item.Name;
            existingItem.Quantity = item.Quantity;
            existingItem.Price = item.Price;
        }

        return Task.CompletedTask;
    }

    public Task DeleteItem(int id)
    {
        var item = _items.FirstOrDefault(i => i.Id == id);
        if (item != null)
        {
            _items.Remove(item);
        }

        return Task.CompletedTask;
    }
}