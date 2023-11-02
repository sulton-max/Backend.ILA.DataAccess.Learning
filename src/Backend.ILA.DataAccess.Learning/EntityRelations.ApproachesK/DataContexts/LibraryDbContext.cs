using EntityRelations.ApproachesK.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityRelations.ApproachesK.DataContexts;

public class LibraryDbContext : DbContext
{
    public DbSet<Book> Books => Set<Book>();

    public DbSet<Author> Authors => Set<Author>();

    public LibraryDbContext() : base(new DbContextOptionsBuilder<LibraryDbContext>()
        .UseNpgsql("Host=localhost;Port=5432;Database=EfRelations.ApproachK;Username=postgres;Password=postgres")
        .Options)
    {
    }

    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LibraryDbContext).Assembly);
    }
}