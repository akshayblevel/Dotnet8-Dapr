using Consumer.Extensions;
using Consumer.Models;

namespace Consumer.Services
{
    public class ItemService : IItemService
    {
        private readonly HttpClient client;

        public ItemService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<IEnumerable<Item>> GetAll()
        {
            var response = await client.GetAsync("Item");
            return await response.ReadContentAs<List<Item>>();
        }

        public async Task<Item> GetItem(Guid id)
        {
            var response = await client.GetAsync($"Item/{id}");
            return await response.ReadContentAs<Item>();
        }
    }
}
