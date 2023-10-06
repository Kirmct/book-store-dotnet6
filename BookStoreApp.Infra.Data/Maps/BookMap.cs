using BookStoreApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStoreApp.Infra.Data.Maps
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("book");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Title).HasColumnName("title");
            builder.Property(x => x.Description).HasColumnName("description");
            builder.Property(x => x.PublishingCompanyId).HasColumnName("id_company");

            builder.HasOne(x => x.PublishingCompany)
                .WithMany(b => b.Books)
                .HasForeignKey(b => b.PublishingCompanyId).HasConstraintName("fk_book_company").IsRequired(false);
        }
    }
}
