using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class BoxDbContext: DbContext
{
    public BoxDbContext(DbContextOptions<BoxDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Box>()
            .Property(b => b.Id)
            .ValueGeneratedOnAdd();
        
        /*modelBuilder.Entity<Box>()
           .HasOne(b => b.BoxType);

        modelBuilder.Entity<BoxType>()
            .Property(bt => bt.Id)
           .ValueGeneratedOnAdd();
           */

    }

    public DbSet<Box> Boxes { get; set; }
    public DbSet<BoxType> BoxTypes { get; set; }
}