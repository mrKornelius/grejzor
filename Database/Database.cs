using Microsoft.EntityFrameworkCore;
using grejzor.Core;

namespace grejzor.Database;

public class Database : DbContext
{
    public Database(DbContextOptions<Database> options) : base(options) { }

    public DbSet<Item> Items { get; set; }
    public DbSet<BorrowRequest> BorrowRequests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // base.OnModelCreating(modelBuilder);
        //FIXME: just for testing
        modelBuilder.Entity<Item>().HasData(new Item() { Id = 1, Name = "Hammare", Description = "En bra hammare..." });
        modelBuilder.Entity<Item>().HasData(new Item() { Id = 2, Name = "Cykel", Description = "Snabb som fan!" });
        modelBuilder.Entity<Item>().HasData(new Item() { Id = 3, Name = "Laptop", Description = "en mac..." });
        modelBuilder.Entity<Item>().HasData(new Item() { Id = 4, Name = "Kaffebryggare", Description = "12 koppar" });
        modelBuilder.Entity<Item>().HasData(new Item() { Id = 5, Name = "Bok", Description = "Banana Fish (jätte bra)" });
    }
}
