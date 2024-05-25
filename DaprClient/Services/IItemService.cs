using Consumer.Models;

namespace Consumer.Services
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> GetAll();
        Task<Item> GetItem(Guid id);
    }
}
