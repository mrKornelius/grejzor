using Microsoft.EntityFrameworkCore;
using grejzor.Database;
using grejzor.Core;

namespace grejzor.Core.Services;

public class ItemService
{
    private readonly DbContext _dbContext;
    public ItemService(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Dictionary<Item, string> GetAllItems()
    {
        // List<Item> items = _DbContext;
        return new();
    }
}
