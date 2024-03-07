using Microsoft.EntityFrameworkCore;
using grejzor.Database;
// using grejzor.Core;

namespace grejzor.Core;

public class BorrowService
{
    private readonly DbContext _dbContext;
    public BorrowService(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Dictionary<Item, string> GetAllItems()
    {
        // var items = _dbContext.Items;
        return new();
    }
}
