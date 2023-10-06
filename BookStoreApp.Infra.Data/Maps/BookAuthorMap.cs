using BookStoreApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStoreApp.Infra.Data.Maps
{
    public class BookAuthorMap : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.ToTable("book_author");
            builder.HasKey(ba => new { ba.BookId, ba.AuthorId});

            builder.Property(x => x.AuthorId).HasColumnName("id_author");
            builder.Property(x => x.BookId).HasColumnName("id_book");

            builder.HasOne(x => x.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(x => x.BookId)
                .HasConstraintName("fk_book_author_book");

            builder.HasOne(x => x.Author)
               .WithMany(a => a.BookAuthors)
               .HasForeignKey(x => x.AuthorId)
               .HasConstraintName("fk_book_author_author");
        }
    }
}
