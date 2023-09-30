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
    }
}