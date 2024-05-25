using DaprService.Models;

namespace DaprService.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private List<Item> Items = new List<Item>();

        public ItemRepository()
        {
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            var item1Guid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA317}");
            var item2Guid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA318}");
            var item3Guid = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA319}");

            Items.Add(new Item
            {
                ItemId = item1Guid,
                Name = "Item 1",
                Price = 65,
                Date = DateTime.Now.AddMonths(6),
                Description = "Description for Item 1.",
            });

            Items.Add(new Item
            {
                ItemId = item2Guid,
                Name = "Item 2",
                Price = 85,
                Date = DateTime.Now.AddMonths(9),
                Description = "Description for Item 2",
            });

            Items.Add(new Item
            {
                ItemId = item3Guid,
                Name = "Item 3",
                Price = 135,
                Date = DateTime.Now.AddMonths(8),
                Description = "Description for Item 3",
            });
        }

        public async Task<IEnumerable<Item>> GetItems()
        {
            return Items;
        }


        public Task<Item> GetItemById(Guid ItemId)
        {
            var item = Items.FirstOrDefault(e => e.ItemId == ItemId);
            if (item == null)
            {
                throw new InvalidOperationException("Item not found");
            }
            return Task.FromResult(item);
        }
    }
}
