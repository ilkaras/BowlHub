using BowlHub.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BowlHub.DAL.DbData;

public static class DbBoardsGenerator
{
    private static List<BoardEntity> _boardEntities = new List<BoardEntity>
    {
        new BoardEntity
        {
            Id = new Guid("7f319f6e-85dd-4e23-ac9f-5acd0b2a1b39"),
            PlaceId = new Guid("60dc9058-55d3-4a55-9594-a9684a503c5b"),
            ColumnCount = 5,
            StartTime = "12:00",
            EndTime = "17:00",
        },
        new BoardEntity
        {
            Id = new Guid("d8b70b7d-59d9-4469-a8a5-84fe2c0f35bb"),
            PlaceId = new Guid("9a946ef3-1d89-4764-9e81-43813bb422c1"),
            ColumnCount = 8,
            StartTime = "10:00",
            EndTime = "22:00",
        },
        new BoardEntity
        {
            Id = new Guid("a5e6e90f-9d38-4a4d-8e29-138f0764b0f8"),
            PlaceId = new Guid("aaa85140-61ee-4e07-9ba8-32733a38442d"),
            ColumnCount = 14,
            StartTime = "8:00",
            EndTime = "20:00",
        },

    };

    public static void Generate(ModelBuilder builder)
    {
        builder.Entity<BoardEntity>()
            .HasData(_boardEntities);
    }
}