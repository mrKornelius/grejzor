using grejzor.Database;
using Microsoft.EntityFrameworkCore;

namespace grejzor.Core;

public class BorrowService
{
    private readonly GrejzorDB _dbContext;

    public BorrowService(GrejzorDB dbContext)
    {
        _dbContext = dbContext;
    }

    public Dictionary<Item, string> GetAllItems()
    {
        Dictionary<Item, string> dict = new();
        foreach (var item in _dbContext.Items.ToList())
        {
            dict[item] = "Available";
        }
        return dict;
    }
}
