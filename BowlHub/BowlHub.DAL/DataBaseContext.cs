using BowlHub.DAL.DbData;
using BowlHub.DAL.EntitiConfigurations;
using BowlHub.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace BowlHub.DAL;

public class DataBaseContext : DbContext
{
    public virtual DbSet<UserEntity> Users { get; set; } = default!;
    public virtual DbSet<PlaceEntity> Places { get; set; } = default!;
    public virtual DbSet<BoardEntity> Boards { get; set; } = default!;
    public virtual DbSet<ReservationEntity> Reservations { get; set; } = default!;

    private readonly IConfiguration _configuration;

    public DataBaseContext(DbContextOptions<DataBaseContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BoardConfiguration());
        modelBuilder.ApplyConfiguration(new PlaceConfiguration());
        modelBuilder.ApplyConfiguration(new ReservationConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguraton());
        base.OnModelCreating(modelBuilder);
        DbPlacesGenerator.Generate(modelBuilder);
        DbBoardsGenerator.Generate(modelBuilder);
    }
}