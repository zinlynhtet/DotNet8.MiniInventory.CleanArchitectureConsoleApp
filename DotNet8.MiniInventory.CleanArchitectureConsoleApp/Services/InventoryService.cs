public class InventoryService
{
    private readonly IInventoryRepository _repository;

    public InventoryService(IInventoryRepository repository) => _repository = repository;

    public void AddItem(string name, int quantity, decimal price)
    {
        var item = new InventoryItem
        {
            Name = name,
            Quantity = quantity,
            Price = price
        };
        _repository.AddItem(item);
    }

    public List<InventoryItem> ListItems()
    {
        return _repository.GetItems();
    }

    public void UpdateItem(int id, string name, int quantity, decimal price)
    {
        var item = _repository.GetItemById(id);
        if (item is null) return;
        item.Name = name;
        item.Quantity = quantity;
        item.Price = price;
        _repository.UpdateItem(item);
    }

    public void DeleteItem(int id)
    {
        _repository.DeleteItem(id);
    }
}