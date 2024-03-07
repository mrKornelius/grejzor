using Microsoft.EntityFrameworkCore;
using grejzor.Core;

namespace grejzor.Database;

public class Database : DbContext
{
    public Database(DbContextOptions<Database> options) : base(options) { }

    public DbSet<Item> Items { get; set; }
    public DbSet<BorrowRequest> BorrowRequests { get; set; }
}
