using EntityRelations.ApproachesA.DataContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

var services = new ServiceCollection();

services.AddDbContext<LibraryDbContext>(options =>
    options.UseNpgsql("Host=localhost;Port=5432;Database=EfRelations.ApproachA;Username=postgres;Password=postgres"));

var serviceProvider = services.BuildServiceProvider();

var dbContext = serviceProvider.GetRequiredService<LibraryDbContext>();