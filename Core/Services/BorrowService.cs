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

    public async Task<Item?> GetItemById(int id)
    {
        return await _dbContext.Items.FindAsync(id);
    }

    public async Task<bool> CreateBorrowRequest(int Id, string name)
    {
        BorrowRequest request = new(Id, name);
        await _dbContext.BorrowRequests.AddAsync(request);
        await _dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<List<BorrowRequest>> GetAllBorrowRequestsAsync()
    {
        return await _dbContext.BorrowRequests.ToListAsync();
    }




    // public async Task<ItemSpecifics> GetItemByIdAsync(int id)
    // {
    //     Item? item = await _dbContext.Items.FindAsync(id);
    //     _dbContext.BorrowRequests.Select(x => x.ItemId == id);

    //     return new() { Name = item.Name, Description = item.Description };
    // }
}

