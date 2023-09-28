using BowlHub.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BowlHub.DAL.EntitiConfigurations;

public class UserConfiguraton : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.HasIndex(x => x.Id);
        builder.Property(x => x.Email);
        builder.Property(x => x.Password);
        builder.Property(x => x.Name);

        builder
            .HasMany(x => x.Reservations)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId)
            .HasPrincipalKey(x => x.Id)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}
