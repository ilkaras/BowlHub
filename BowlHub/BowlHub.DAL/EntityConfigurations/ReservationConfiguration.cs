using BowlHub.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BowlHub.DAL.EntitiConfigurations;

public class ReservationConfiguration : IEntityTypeConfiguration<ReservationEntity>
{
    public void Configure(EntityTypeBuilder<ReservationEntity> builder)
    {
        builder.HasIndex(x => x.Id);
        builder.Property(x => x.UserId);
        builder.Property(x => x.BoardId);
        builder.Property(x => x.ColumnNum);
        builder.Property(x => x.FromReservation);
        builder.Property(x => x.TillReservation);
        builder.Property(x => x.DateReservation);
    }
}