using BowlHub.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BowlHub.DAL.EntitiConfigurations;

public class PlaceConfiguration : IEntityTypeConfiguration<PlaceEntity>
{
    public void Configure(EntityTypeBuilder<PlaceEntity> builder)
    {
        builder.HasIndex(x => x.Id);
        builder.HasIndex(x => x.Name);
        builder.Property(x => x.City);
        builder.Property(x => x.Adress);
        builder.Property(x => x.AdminPhone);

        builder
            .HasMany(x => x.Boards)
            .WithOne(x => x.Place)
            .HasForeignKey(x => x.PlaceId)
            .HasPrincipalKey(x => x.Id)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}
