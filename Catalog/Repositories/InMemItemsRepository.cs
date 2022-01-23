using Catalog.Entities;

namespace Catalog.Repositories
{
    public class InMemitemsRepository
    {
        private readonly List<Item> _items = new()
        {
            new Item 
            { 
                Id = Guid.NewGuid(), 
                Name = "Potion",
                Price = 9,
                CreatedDate = DateTimeOffset.UtcNow
            },
            new Item 
            {
                Id = Guid.NewGuid(),
                Name = "Iron Sword",
                Price = 20,
                CreatedDate = DateTimeOffset.UtcNow
            },
            new Item 
            {
                Id = Guid.NewGuid(),
                Name = "Bronz Shield",
                Price = 18,
                CreatedDate = DateTimeOffset.UtcNow
            }
        };

        public IEnumerable<Item> GetItems()
        {
            return _items;
        }

        public Item GetItem(Guid id)
        {
            return _items.Where(item => item.Id == id).SingleOrDefault();
        }
    }
}