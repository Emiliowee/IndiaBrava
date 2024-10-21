using Microsoft.EntityFrameworkCore;

public class IndiaBravaContext : DbContext
{
    public IndiaBravaContext(DbContextOptions<IndiaBravaContext> options)
        : base(options)
    {
    }

    public DbSet<Producto> Productos { get; set; }
}
