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
        modelBuilder.Entity<Item>().HasData(new Item() { Id = 1, Name = "Hammare", Desctiption = "En bra hammare..." });
        modelBuilder.Entity<Item>().HasData(new Item() { Id = 2, Name = "Cykel", Desctiption = "Snabb som fan!" });
        modelBuilder.Entity<Item>().HasData(new Item() { Id = 3, Name = "Laptop", Desctiption = "en mac..." });
        modelBuilder.Entity<Item>().HasData(new Item() { Id = 4, Name = "Kaffebryggare", Desctiption = "12 koppar" });
        modelBuilder.Entity<Item>().HasData(new Item() { Id = 5, Name = "Bok", Desctiption = "Banana Fish (jätte bra)" });
    }
}
