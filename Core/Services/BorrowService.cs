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

    public async Task<Dictionary<Item, string>> GetAllItemsAsync()
    {
        Dictionary<Item, string> dict = new();
        foreach (var item in await _dbContext.Items.ToListAsync())
        {
            dict[item] = "Available";
        }
        return dict;
    }

    // public async Task<ItemSpecifics> GetItemByIdAsync(int id)
    // {
    //     Item item = _dbContext.Items.Find(id);
    //     _dbContext.BorrowRequests.Select(x => x.ItemId == id)

    //     return new() { Name = item.Name, Description = item.Description };
    // }
}

