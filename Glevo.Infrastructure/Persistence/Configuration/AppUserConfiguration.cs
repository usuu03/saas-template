using Glevo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Glevo.Infrastructure.Persistence.Configuration;

public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.ToTable("users");
        builder.Property(t => t.CreatedAt)
            .HasDefaultValueSql("NOW()")
            .ValueGeneratedOnAdd()
            .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

       builder.Property(t => t.FirstName)
           .IsRequired()
           .HasMaxLength(100);

       builder.Property(t => t.LastName)
           .IsRequired()
           .HasMaxLength(100);

       builder.Property(t => t.AvatarUrl)
           .HasMaxLength(2048);
    }

}