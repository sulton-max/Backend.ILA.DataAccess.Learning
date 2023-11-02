using EfCore.ContextConfiguration.Approaches.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCore.ContextConfiguration.Approaches.DataContext.InternalConfiguration;

public class LibraryDbContext : DbContext
{
    public DbSet<Book> Books => Set<Book>();

    public DbSet<Author> Authors => Set<Author>();

    public LibraryDbContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("LibraryDatabase.Internal");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // add seed data for author and book
        modelBuilder
            .Entity<Author>()
            .HasData(new Author
            {
                Id = Guid.Parse("4941DEC3-36F6-412D-BABC-ABD92B79B9BB"),
                Name = "Andrew Troelsen"
            });

        modelBuilder
            .Entity<Book>()
            .HasData(new Book
                {
                    Id = Guid.Parse("E9582B0D-A6C7-4FDB-B17B-7E9D64E5B784"),
                    Title = "Asp.Net Core in Action (2018)",
                    Genre = "Programming",
                    Pages = 616,
                    AuthorId = Guid.Parse("4941DEC3-36F6-412D-BABC-ABD92B79B9BB"),
                },
                new Book
                {
                    Id = Guid.Parse("C50443A7-B9DA-4060-A827-E9360A7491CA"),
                    Title = "Pro C# 7: With .NET and .NET Core (2017)",
                    Genre = "Programming",
                    Pages = 1372,
                    AuthorId = Guid.Parse("4941DEC3-36F6-412D-BABC-ABD92B79B9BB"),
                });
    }
}