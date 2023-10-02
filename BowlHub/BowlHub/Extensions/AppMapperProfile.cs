using AutoMapper;
using BowlHub.BLL.Models;
using BowlHub.DTOs;

namespace BowlHub.Extensions;

public class AppMapperProfile : Profile
{
    public AppMapperProfile()
    {
        CreateMap<PlaceDto, PlaceModel>()
            .ForMember(place => place.Id,
                opt => opt.MapFrom(place => place.Id))
            .ForMember(place => place.Name,
                opt => opt.MapFrom(place => place.Name))
            .ForMember(place => place.City,
                opt => opt.MapFrom(place => place.City))
            .ForMember(place => place.Address,
                opt => opt.MapFrom(place => place.Address))
            .ForMember(place => place.AdminPhone,
                opt => opt.MapFrom(place => place.AdminPhone));
        
        CreateMap<PlaceModel, PlaceDto>()
            .ForMember(place => place.Id,
                opt => opt.MapFrom(place => place.Id))
            .ForMember(place => place.Name,
                opt => opt.MapFrom(place => place.Name))
            .ForMember(place => place.City,
                opt => opt.MapFrom(place => place.City))
            .ForMember(place => place.Address,
                opt => opt.MapFrom(place => place.Address))
            .ForMember(place => place.AdminPhone,
                opt => opt.MapFrom(place => place.AdminPhone));
        
        CreateMap<BoardDto, BoardModel>()
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
        
        CreateMap<BoardModel, BoardDto>()
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
        
        CreateMap<ReservationModel, ReservationDto>()
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
        
        CreateMap<ReservationDto, ReservationModel>()
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

        CreateMap<UserDto, UserModel>()
            .ForMember(place => place.Id,
                opt => opt.MapFrom(place => place.Id))
            .ForMember(place => place.Email,
                opt => opt.MapFrom(place => place.Email))
            .ForMember(place => place.Password,
                opt => opt.MapFrom(place => place.Password))
            .ForMember(place => place.Name,
                opt => opt.MapFrom(place => place.Name));
        
        CreateMap<UserModel, UserDto>()
            .ForMember(place => place.Id,
                opt => opt.MapFrom(place => place.Id))
            .ForMember(place => place.Email,
                opt => opt.MapFrom(place => place.Email))
            .ForMember(place => place.Password,
                opt => opt.MapFrom(place => place.Password))
            .ForMember(place => place.Name,
                opt => opt.MapFrom(place => place.Name));
        
        CreateMap<UserSignupDto, UserModel>()
            .ForMember(place => place.Email,
                opt => opt.MapFrom(place => place.Email))
            .ForMember(place => place.Password,
                opt => opt.MapFrom(place => place.Password))
            .ForMember(place => place.Name,
                opt => opt.MapFrom(place => place.Name));
    }
}
