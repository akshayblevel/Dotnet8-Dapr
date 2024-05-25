using Consumer.Models;
using Consumer.Services;
using Microsoft.AspNetCore.Mvc;

namespace Consumer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController(IItemService itemService) : ControllerBase
    {
        [HttpGet(Name = "GetProducts")]
        public async Task<IEnumerable<Item>> Get()
        {
            return await itemService.GetAll();
        }
    }
}
