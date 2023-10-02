using BowlHub.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BowlHub.DAL.EntitiConfigurations;

public class BoardConfiguration : IEntityTypeConfiguration<BoardEntity>
{
    public void Configure(EntityTypeBuilder<BoardEntity> builder)
    {
        builder.HasIndex(x => x.Id);
        builder.Property(x => x.PlaceId);
        builder.Property(x => x.ColumnCount);
        builder.Property(x => x.StartTime);
        builder.Property(x => x.EndTime);

        builder
            .HasMany(x => x.Reservations)
            .WithOne(x => x.Board)
            .HasForeignKey(x => x.BoardId)
            .HasPrincipalKey(x => x.Id)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}