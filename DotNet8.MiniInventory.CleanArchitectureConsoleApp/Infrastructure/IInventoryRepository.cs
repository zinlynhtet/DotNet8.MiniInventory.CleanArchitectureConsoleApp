public interface IInventoryRepository
{
    Task AddItem(InventoryItem item);
    Task<List<InventoryItem>> GetItems();
    Task<InventoryItem> GetItemById(int id);
    Task UpdateItem(InventoryItem item);
    Task DeleteItem(int id);
}