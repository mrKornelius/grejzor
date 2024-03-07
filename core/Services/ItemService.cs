using Microsoft.EntityFrameworkCore;
using grejzor.Database;
using grejzor.core;

namespace grejzor;

public class ItemService
{
    private readonly DbContext _DbContext;
    public ItemService(DbContext dbContext)
    {
        _DbContext = dbContext;
    }

    public Dictionary<Item, string> GetAllItems()
    {
        // List<Item> items = _DbContext;
        return new();
    }
}
