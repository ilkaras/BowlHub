using BowlHub.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BowlHub.DAL.DbData;

public static class DbPlacesGenerator
{
    private static List<PlaceEntity> _placeEntities = new List<PlaceEntity>
    {
        new PlaceEntity
        {
            Id = Guid.NewGuid(),
            Name = "Sharaga",
            City = "Kropyvnytskyi",
            Adress = "Kropyvnytskogo 7",
            AdminPhone = "+380 (66) 666-66-66"
        },
        new PlaceEntity
        {
            Id = Guid.NewGuid(),
            Name = "Sharaga",
            City = "Kropyvnytskyi",
            Adress = "Kropyvnytskogo 7",
            AdminPhone = "+380 (66) 666-66-66"
        },
        new PlaceEntity
        {
            Id = Guid.NewGuid(),
            Name = "Sharaga",
            City = "Kropyvnytskyi",
            Adress = "Kropyvnytskogo 7",
            AdminPhone = "+380 (66) 666-66-66"
        },
    };
    public static void Generate(ModelBuilder builder)
    {
        builder.Entity<PlaceEntity>()
            .HasData(_placeEntities);
    }
}