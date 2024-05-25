using DaprService.Models;
using DaprService.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DaprService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController(IItemRepository itemRepository) : ControllerBase
    {
        [HttpGet(Name = "GetItems")]
        public async Task<IEnumerable<Item>> GetAll()
        {
            return await itemRepository.GetItems();
        }

        [HttpGet("{id}", Name = "GetById")]
        public async Task<Item> GetById(Guid id)
        {
            return await itemRepository.GetItemById(id);
        }
    }
}
