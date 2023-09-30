using BowlHub.BLL.Services.Classes;
using BowlHub.BLL.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BowlHub.BLL.Extentions;

public static class AddServices
{
    public static void AddServiceInjection(this IServiceCollection services)
    {
        services.AddScoped<IPlaceService, PlaceService>();
        
        services.AddAutoMapper(typeof(AppMappingProfile));
    }
}