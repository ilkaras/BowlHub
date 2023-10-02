using AutoMapper;
using BowlHub.BLL.Models;
using BowlHub.DAL.Entities;

namespace BowlHub.BLL;

public class AppMappingProfile : Profile
{
    public AppMappingProfile()
    {
        CreateMap<PlaceModel, PlaceEntity>()
            .ForMember(place => place.Id,
                opt => opt.MapFrom(place => place.Id))
            .ForMember(place => place.Name,
                opt => opt.MapFrom(place => place.Name))
            .ForMember(place => place.City,
                opt => opt.MapFrom(place => place.City))
            .ForMember(place => place.Adress,
                opt => opt.MapFrom(place => place.Address))
            .ForMember(place => place.AdminPhone,
                opt => opt.MapFrom(place => place.AdminPhone));
        
        CreateMap<PlaceEntity, PlaceModel>()
            .ForMember(place => place.Id,
                opt => opt.MapFrom(place => place.Id))
            .ForMember(place => place.Name,
                opt => opt.MapFrom(place => place.Name))
            .ForMember(place => place.City,
                opt => opt.MapFrom(place => place.City))
            .ForMember(place => place.Address,
                opt => opt.MapFrom(place => place.Adress))
            .ForMember(place => place.AdminPhone,
                opt => opt.MapFrom(place => place.AdminPhone));
        
                CreateMap<BoardEntity, BoardModel>()
            .ForMember(place => place.Id,
                opt => opt.MapFrom(place => place.Id))
            .ForMember(place => place.PlaceId,
                opt => opt.MapFrom(place => place.PlaceId))
            .ForMember(place => place.ColumnCount,
                opt => opt.MapFrom(place => place.ColumnCount))
            .ForMember(place => place.StartTime,
                opt => opt.MapFrom(place => place.StartTime))
            .ForMember(place => place.EndTime,
                opt => opt.MapFrom(place => place.EndTime));
        
        CreateMap<BoardModel, BoardEntity>()
            .ForMember(place => place.Id,
                opt => opt.MapFrom(place => place.Id))
            .ForMember(place => place.PlaceId,
                opt => opt.MapFrom(place => place.PlaceId))
            .ForMember(place => place.ColumnCount,
                opt => opt.MapFrom(place => place.ColumnCount))
            .ForMember(place => place.StartTime,
                opt => opt.MapFrom(place => place.StartTime))
            .ForMember(place => place.EndTime,
                opt => opt.MapFrom(place => place.EndTime));
        
        CreateMap<ReservationModel, ReservationEntity>()
            .ForMember(place => place.Id,
                opt => opt.MapFrom(place => place.Id))
            .ForMember(place => place.UserId,
                opt => opt.MapFrom(place => place.UserId))
            .ForMember(place => place.BoardId,
                opt => opt.MapFrom(place => place.BoardId))
            .ForMember(place => place.ColumnNum,
                opt => opt.MapFrom(place => place.ColumnNum))
            .ForMember(place => place.FromReservation,
                opt => opt.MapFrom(place => place.FromReservation))
            .ForMember(place => place.TillReservation,
                opt => opt.MapFrom(place => place.TillReservation))
            .ForMember(place => place.DateReservation,
                opt => opt.MapFrom(place => place.DateReservation));
        
        CreateMap<ReservationEntity, ReservationModel>()
            .ForMember(place => place.Id,
                opt => opt.MapFrom(place => place.Id))
            .ForMember(place => place.UserId,
                opt => opt.MapFrom(place => place.UserId))
            .ForMember(place => place.BoardId,
                opt => opt.MapFrom(place => place.BoardId))
            .ForMember(place => place.ColumnNum,
                opt => opt.MapFrom(place => place.ColumnNum))
            .ForMember(place => place.FromReservation,
                opt => opt.MapFrom(place => place.FromReservation))
            .ForMember(place => place.TillReservation,
                opt => opt.MapFrom(place => place.TillReservation))
            .ForMember(place => place.DateReservation,
                opt => opt.MapFrom(place => place.DateReservation));

        CreateMap<UserEntity, UserModel>()
            .ForMember(place => place.Id,
                opt => opt.MapFrom(place => place.Id))
            .ForMember(place => place.Email,
                opt => opt.MapFrom(place => place.Email))
            .ForMember(place => place.Password,
                opt => opt.MapFrom(place => place.Password))
            .ForMember(place => place.Name,
                opt => opt.MapFrom(place => place.Name));
        
        CreateMap<UserModel, UserEntity>()
            .ForMember(place => place.Id,
                opt => opt.MapFrom(place => place.Id))
            .ForMember(place => place.Email,
                opt => opt.MapFrom(place => place.Email))
            .ForMember(place => place.Password,
                opt => opt.MapFrom(place => place.Password))
            .ForMember(place => place.Name,
                opt => opt.MapFrom(place => place.Name));
    }
}