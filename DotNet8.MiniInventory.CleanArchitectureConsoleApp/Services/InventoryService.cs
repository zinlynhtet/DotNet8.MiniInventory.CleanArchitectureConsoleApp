public class InventoryService
{
    private readonly IInventoryRepository _repository;

    public InventoryService(IInventoryRepository repository)
    {
        _repository = repository;
    }

    public async Task AddItemAsync(string name, int quantity, decimal price)
    {
        var item = new InventoryItem
        {
            Name = name,
            Quantity = quantity,
            Price = price
        };
        await _repository.AddItem(item);
    }

    public async Task<List<InventoryItem>> ListItems()
    {
        return await _repository.GetItems();
    }

    public async Task UpdateItem(int id, string name, int quantity, decimal price)
    {
        var item = await _repository.GetItemById(id);
        if (item != null)
        {
            item.Name = name;
            item.Quantity = quantity;
            item.Price = price;
            await _repository.UpdateItem(item);
        }
    }

    public async Task DeleteItem(int id)
    {
        await _repository.DeleteItem(id);
    }
}