public interface IInventoryRepository
{
    void AddItem(InventoryItem item);
    List<InventoryItem> GetItems();
    InventoryItem GetItemById(int id);
    void UpdateItem(InventoryItem item);
    void DeleteItem(int id);
}