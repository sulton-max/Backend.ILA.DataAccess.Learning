using EfCore.ContextConfiguration.Approaches.DataContext.InternalConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var libraryContextWithInternalConfiguration = new EfCore.ContextConfiguration.Approaches.DataContext.InternalConfiguration.LibraryDbContext();
var booksA = libraryContextWithInternalConfiguration.Books
    .AsNoTracking()
    .Include(book => book.Author)
    .ToList();

booksA.ForEach(book => Console.WriteLine(book.Title + " by " + book.Author.Name));

Console.WriteLine(libraryContextWithInternalConfiguration.Books.Count());

var services = new ServiceCollection();
services.AddDbContext<EfCore.ContextConfiguration.Approaches.DataContext.ExternalConfiguration.LibraryDbContext>(options =>
    options.UseInMemoryDatabase("LibraryDatabase.External"));

var provider = services.BuildServiceProvider();
var libraryContextWithExternalConfiguration =
    provider.GetRequiredService<EfCore.ContextConfiguration.Approaches.DataContext.ExternalConfiguration.LibraryDbContext>();

var booksB = libraryContextWithExternalConfiguration.Books
    .AsNoTracking()
    .Include(book => book.Author)
    .ToList();

booksB.ForEach(book => Console.WriteLine(book.Title + " by " + book.Author.Name));


var optionsBuilder = new DbContextOptionsBuilder<LibraryDbContext>();
optionsBuilder.UseInMemoryDatabase("");

var test = optionsBuilder.Options;