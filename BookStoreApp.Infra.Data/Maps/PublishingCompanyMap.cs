using BookStoreApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStoreApp.Infra.Data.Maps
{
    public class PublishingCompanyMap : IEntityTypeConfiguration<PublishingCompany>
    {
        public void Configure(EntityTypeBuilder<PublishingCompany> builder)
        {
            builder.ToTable("publishing_company");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Cnpj).HasColumnName("cnpj");
            builder.Property(x => x.SocialName).HasColumnName("social_name");

            builder.HasMany(x => x.Books)
                .WithOne(b => b.PublishingCompany)
                .HasForeignKey(b => b.PublishingCompanyId);
        }
    }
}
