using Microsoft.EntityFrameworkCore;
using grejzor.Database;
// using grejzor.Core;

namespace grejzor.Core;

public class ItemService
{
    private readonly DbContext _dbContext;
    public ItemService(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Dictionary<Item, string> GetAllItems()
    {
        // var items = _dbContext.Items;
        return new();
    }
}
