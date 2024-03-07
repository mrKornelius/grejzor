using Microsoft.EntityFrameworkCore;
using grejzor.Core;

namespace grejzor.Database;

public class GrejzorDB : DbContext
{
    public GrejzorDB(DbContextOptions<GrejzorDB> options) : base(options) { }

    public DbSet<Item> Items { get; set; }
    public DbSet<BorrowRequest> BorrowRequests { get; set; }
}
