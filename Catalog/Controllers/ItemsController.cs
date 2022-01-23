using Catalog.Entities;
using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly InMemitemsRepository _repository;

        public ItemsController()
        {
            _repository = new InMemitemsRepository();
        }

        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = _repository.GetItems();
            return items;
        }
    }
}