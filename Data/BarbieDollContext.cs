using Microsoft.EntityFrameworkCore;
using BarbieDoll.Models;
public class BarbieDollContext : DbContext
{
    public BarbieDollContext(DbContextOptions<BarbieDollContext> options)
        : base(options)
    {
    }

    public DbSet<Doll> Doll { get; set; }
}

