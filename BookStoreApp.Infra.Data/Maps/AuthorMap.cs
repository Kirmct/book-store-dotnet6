using BookStoreApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStoreApp.Infra.Data.Maps
{
    internal class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("author");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.AuthorName).HasColumnName("autho_name");
            builder.Property(x => x.Birthday).HasColumnName("birthday");
            builder.Property(x => x.Country).HasColumnName("country");

        }
    }
}
