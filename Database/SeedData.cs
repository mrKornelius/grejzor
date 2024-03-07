using Microsoft.EntityFrameworkCore;
using grejzor.Core;

namespace grejzor.Database;


public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new GrejzorDB(
            serviceProvider.GetRequiredService<
                DbContextOptions<GrejzorDB>>()))
        {
            context.Items.AddRange(
                new Item() { Id = 1, Name = "Hammare", Description = "En bra hammare..." },
                new Item() { Id = 2, Name = "Cykel", Description = "Snabb som fan!" },
                new Item() { Id = 3, Name = "Laptop", Description = "en mac..." },
                new Item() { Id = 4, Name = "Kaffebryggare", Description = "12 koppar" },
                new Item() { Id = 5, Name = "Bok", Description = "Banana Fish (jätte bra)" }
            );
            context.SaveChanges();
        }
    }
}
