﻿using EntityRelations.ApproachesH.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityRelations.ApproachesH.DataContexts;

public class LibraryDbContext : DbContext
{
    public DbSet<Book> Books => Set<Book>();

    public DbSet<Author> Authors => Set<Author>();

    public LibraryDbContext() : base(new DbContextOptionsBuilder<LibraryDbContext>()
        .UseNpgsql("Host=localhost;Port=5432;Database=EfRelations.ApproachH;Username=postgres;Password=postgres")
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