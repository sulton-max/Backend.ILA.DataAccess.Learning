using EntityRelations.ApproachesE.DataContexts;
using Microsoft.EntityFrameworkCore;

var options = new DbContextOptionsBuilder<LibraryDbContext>();
options.UseNpgsql("Host=localhost;Port=5432;Database=EfRelations.ApproachE;Username=postgres;Password=postgres");

var dbContext = new LibraryDbContext(options.Options);

Console.WriteLine(dbContext.Books.Count());