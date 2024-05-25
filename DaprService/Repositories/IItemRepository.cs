using DaprService.Models;

namespace DaprService.Repositories
{
    public interface IItemRepository
    {
        Task<IEnumerable<Item>> GetItems();
        Task<Item> GetItemById(Guid ItemId);
    }
}