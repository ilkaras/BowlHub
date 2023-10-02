using BowlHub.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BowlHub.DAL.DbData;

public static class DbPlacesGenerator
{
    private static List<PlaceEntity> _placeEntities = new List<PlaceEntity>
    {
        new PlaceEntity
        {
            Id = new Guid("60dc9058-55d3-4a55-9594-a9684a503c5b"),
            Name = "Sharaga",
            City = "Kropyvnytskyi",
            Adress = "Kropyvnytskogo 7",
            AdminPhone = "+380 (66) 666-66-66"
        },
        new PlaceEntity
        {
            Id = new Guid("9a946ef3-1d89-4764-9e81-43813bb422c1"),
            Name = "Sharaga",
            City = "Kropyvnytskyi",
            Adress = "Kropyvnytskogo 7",
            AdminPhone = "+380 (66) 666-66-66"
        },
        new PlaceEntity
        {
            Id = new Guid("aaa85140-61ee-4e07-9ba8-32733a38442d"),
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