using EntityRelations.ApproachesD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityRelations.ApproachesD.EntityConfigurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasData(new Author
        {
            Id = Guid.Parse("4941DEC3-36F6-412D-BABC-ABD92B79B9BB"),
            Name = "Andrew Troelsen"
        });
    }
}