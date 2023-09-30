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
    }
}